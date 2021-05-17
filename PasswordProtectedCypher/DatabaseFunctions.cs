using System;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Security.Cryptography;

namespace PasswordProtectedCypher
{
    class DatabaseFunctions
    {
        const string connectString = "datasource = localhost; Port = 3307; username = 'root'; password = ''; database = caesar_cypher;";
        public static bool AttemptSecureLogin(string username, string password)
        {
            var success = false;
            try {
                using (var connection = new MySqlConnection(connectString)) {
                    connection.Open();
                    var loginCommand = new MySqlCommand(null, connection) {
                        CommandText =
                        "SELECT * FROM login WHERE userName = @uName AND password = @pWord"
                    };

                    //Creating a prepared statement to help protect against SQL Injection. 
                    var uNameParam = new MySqlParameter("@uName", MySqlDbType.VarChar, 30);
                    var pWordParam = new MySqlParameter("@pWord", MySqlDbType.VarChar, 100);
                    uNameParam.Value = username;
                    pWordParam.Value = EncryptPassword(password);
                    loginCommand.Parameters.Add(uNameParam);
                    loginCommand.Parameters.Add(pWordParam);
                    loginCommand.Prepare();
                    MySqlDataReader reader = loginCommand.ExecuteReader();
                    int count = 0;

                    if (reader.Read()) {
                        MessageBox.Show("Log in successful!", "Success!");
                        var cipherForm = new CipherForm();
                        cipherForm.Activate();
                        cipherForm.Show();
                        success = true;
                    }
                    else if (count > 1) {
                        MessageBox.Show("Duplicate username/password.", "Error");
                    }
                    else {
                        MessageBox.Show("Incorrect username/password.", "Error");
                    }
                    if (success) { MessageBox.Show("Connected"); }
                    connection.Close();
                    return success;
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
                return success;
            }
        }
        public static bool IsUsernameTaken(string newUserName, MySqlConnection connect)
        {
            var isUsernameTaken = false;
            var isUsernameTakenCommand = new MySqlCommand(null, connect) {
                CommandText =
                "SELECT COUNT(*) FROM login WHERE userName = @uName"
            };
            var uNameParam = new MySqlParameter("@uName", MySqlDbType.VarChar, 30) {
                Value = newUserName
            };
            isUsernameTakenCommand.Parameters.Add(uNameParam);
            var result = Convert.ToInt32(isUsernameTakenCommand.ExecuteScalar());
            if (result > 0) { isUsernameTaken = true; }
            return isUsernameTaken;
        }
        public static bool RegisterUser(string newUserName, string newPassword)
        {
            var success = false;
            try {
                using (var connection = new MySqlConnection(connectString)) {
                    connection.Open();
                    if (!IsUsernameTaken(newUserName, connection)) {

                        var registrationCommand = new MySqlCommand(null, connection) {
                            CommandText =
                            "INSERT IGNORE INTO login (userName, password)" +
                            "VALUES (@uName, @pWord)"
                        };
                        var uNameParam = new MySqlParameter("@uName", MySqlDbType.VarChar, 30);
                        var pWordParam = new MySqlParameter("@pWord", MySqlDbType.VarChar, 100);
                        uNameParam.Value = newUserName;
                        pWordParam.Value = EncryptPassword(newPassword);
                        registrationCommand.Parameters.Add(uNameParam);
                        registrationCommand.Parameters.Add(pWordParam);
                        registrationCommand.Prepare();
                        MySqlDataReader reader = registrationCommand.ExecuteReader();
                        int count = 1;
                        while (reader.Read()) { count++; }
                        if (count == 1) {
                            MessageBox.Show($"New user '{newUserName}' created", "Success!");
                            success = true;
                            reader.Dispose();
                        }
                        else if (count > 1) {
                            MessageBox.Show("Duplicate created");
                            reader.Close();
                        }
                        else { MessageBox.Show("Unknown error", "Error"); }

                    }
                    else {
                        connection.Close();
                        MessageBox.Show("This username already exists", "Error");
                    }
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
            return success;
        }
        public static string EncryptPassword(string unencryptedPassword)
        {
            var passwordByteValues = Encoding.UTF8.GetBytes(unencryptedPassword);
            using (var encryptSHA256 = SHA256Managed.Create()) {
                byte[] hashValue = encryptSHA256.ComputeHash(passwordByteValues);
                var encryptedPassword = new StringBuilder();
                for (int i = 0; i < hashValue.Length; i++) {
                    encryptedPassword.Append(hashValue[i].ToString("x2"));
                }
                return encryptedPassword.ToString();
            }
        }
    }
}

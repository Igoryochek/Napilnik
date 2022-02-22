using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode9
{
    class Example
    {
        private TextBox _passportTextbox;
        private MessageBox _messageBox;
        private TextResult _textResult;
        private Form _firstForm;
        private int _minimumRawLength = 10;

        private void CheckButtonClick(object sender, EventArgs e)
        {
            if (_passportTextbox.Text.Trim() == "")
            {
                _messageBox.Show("Введите серию и номер паспорта");
                int firstNumber = _messageBox.Text.ToInt();
            }
            else
            {
                string rawData = _passportTextbox.Text.Trim().Replace(" ", string.Empty);
                if (rawData.Length < _minimumRawLength)
                {
                    _textResult.Text = "Неверный формат серии или номера паспорта";
                }
                else
                {
                    string commandText = string.Format("select * from passports where num='{0}' limit 1;", (object)_firstForm.ComputeSha256Hash(rawData));
                    string connectionString = string.Format("Data Source=" + Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\db.sqlite");
                    try
                    {
                        var connection = new SQLiteConnection(connectionString);
                        connection.Open();
                        var sqLiteDataAdapter = new SQLiteDataAdapter(new SQLiteCommand(commandText, connection));
                        var dataTable1 = new DataTable();
                        DataTable dataTable2 = dataTable1;
                        sqLiteDataAdapter.Fill(dataTable2);

                        if (dataTable1.Rows.Count > 0)
                        {
                            if (Convert.ToBoolean(dataTable1.Rows[0].ItemArray[1]))
                                _textResult.Text = "По паспорту «" + _passportTextbox.Text + "» доступ к бюллетеню на дистанционном электронном голосовании ПРЕДОСТАВЛЕН";
                            else
                                _textResult.Text = "По паспорту «" + _passportTextbox.Text + "» доступ к бюллетеню на дистанционном электронном голосовании НЕ ПРЕДОСТАВЛЯЛСЯ";
                        }
                        else
                        {
                            _textResult.Text = "Паспорт «" + _passportTextbox.Text + "» в списке участников дистанционного голосования НЕ НАЙДЕН";
                        }
                        connection.Close();
                    }
                    catch (SQLiteException ex)
                    {
                        if (ex.ErrorCode != 1)
                            return;

                        _messageBox.Show("Файл db.sqlite не найден. Положите файл в папку вместе с exe.");
                        int secondNumber = _messageBox.Text.ToInt();
                    }
                }
            }
        }
    }
}

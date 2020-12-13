# Table
Class for making easy use of text from csv files

This class uses the CSVreader below.
https://github.com/tikonen/blog/tree/master/csvreader

# Usage
https://blog.naver.com/ssootube/222172628090
한글 사용 설명서는 위 주소에서 참고 하세요.
Place the csv file you want to parse under Assets/Resources and use this where you want to retrieve the text as follows:


Table table = Table.Instance;
table.init();

//Replace the placeholder text value of Input field named InputNickname with the text with the key value InputNickname.
table.setPlaceholder("InputNickname","InputNickname");

//Replace the text value of Button named ButtonLogin with text with the key value of ButtonLogin.
table.setButton("ButtonLogin", "ButtonLogin");

//Gets the text with the key value OK.
string ok = table.getText("OK");

you can see sample.csv file to check the form of csv file.

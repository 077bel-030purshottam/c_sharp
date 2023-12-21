

#include <iostream>
#include <string.h>

using namespace std;

int main()
{
	// for the single character lower to higher
	char ch = 'c';
	cout << "Changing lowercase to uppwer case " << endl;
	cout << char(ch - 32) << endl;
	cout << (ch - 32) << endl;
	cout << "Changing uppercase  to lower case " << endl;
	// for the single character higher to lower
	char ch1 = 'A';
	cout << char(ch1 + 32) << endl;
	cout << (ch1 + 32) << endl;

	//for the string type 
	cout << "***********************************" << endl;
	char str[20];
	cout << "Enter the str" << endl;
	cin.getline(str, 20);
	//gets_s(str);

	cout << "Without changing the case " << str << endl;
	for (int i = 0; i < strlen(str); i++)
	{
		if (str[i] >= 'a' || str[i] <= 'z') {
			str[i] = str[i] - 32;
		}
	}
	cout << "After changing the case " << str << endl;

	cout << "*****************************" << endl;

	char str1[50];
	cin.getline(str1, 50);
	cout << str1;
	

}


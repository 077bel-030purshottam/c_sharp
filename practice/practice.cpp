//#include <iostream>
//// #include <cmath>
//
//using namespace std;
//
//int main()
//{
//    int a = 10;
//    int b = 20;
//    cout <<"before swapping "<<endl<< "The value of a is " << a << "\nThe value of the b is " << b << endl;
//
//    swap(a, b);
//    cout <<"\n\n\after swapping "<<endl<< "The value of a is " << a << "\nThe value of the b is " << b << endl;
//
//    return 0;
//}
// C++ program to Find Sum of Natural Numbers using Recursion

#include <iostream>

using namespace std;
int sum_recursion(int n)
{

    if (n != 0)
    {
        return n + sum_recursion(n - 1);
	}
}
int main()
{
    int n;
    cout << "Enter the  value of the n" << endl;
    cin >> n;
    int sum= 0;
    sum= sum_recursion(n);
    cout << "The sum is " << sum << endl;
    return 0;
}
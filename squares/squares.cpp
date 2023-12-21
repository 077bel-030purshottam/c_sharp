
#include <iostream>
#include <cmath>

using namespace std;
 int square_int( int x)
{
	return pow(x, 2);
}
int main()
{
	 int a = 5;
	 int squares_num = square_int(a);
	cout << "The square of the " << a << " is " << squares_num << endl;

}


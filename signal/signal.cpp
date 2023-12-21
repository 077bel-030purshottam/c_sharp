#include <iostream>
#include <csignal>

using namespace std;
void signalhandling(int signum)
{
	cout << "Interupted  signal(" << signum << ") " << endl;
	exit(signum);
}
int main()
{
	int count = 0;
	signal(SIGINT, signalhandling);
	while (1)
	{
		cout << "going to sleep " << endl;
		count++;
		if (count == 5) {
			break;
		}

	}
	return 0;
}
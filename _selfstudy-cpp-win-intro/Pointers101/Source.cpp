#include <iostream>
#include <string>


using namespace std;

int main()
{
	int myInt = 100;
	cout << "Where (currently) in memory is myInt stored? " << &myInt << endl << endl;
	

	int *myPointer;
	myPointer = &myInt;
	cout << myPointer << endl;


	cout << endl;
	system("pause");
}
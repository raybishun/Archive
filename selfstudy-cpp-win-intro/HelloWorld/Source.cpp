#include <iostream>
#include <string>
using namespace std;

string symbol = "SPX";
int orderNumber = 25;
float qty = 25.5f;
double lastPrice = 75.50;
bool isGoodTillCanceled = false;
const string orderType = "Limit";
char placeOrder = 'n';

int main()
{
	cout << "Hello World!" << endl;
	cout << "------------" << endl;
	cout << "Order Ticket" << endl;
	cout << "------------" << endl;

	cout << "Enter symbol: ";
	cin >> symbol;

	cout << "Enter Qty: ";
	cin >> qty;

	cout << "Place order? ";
	cin >> placeOrder;

	cout << "Order submitted..." << endl;
	cout << "Bought " << qty << " " << symbol << " at $" << lastPrice << " for a debit of " << qty * lastPrice << endl;


	system("pause");
}
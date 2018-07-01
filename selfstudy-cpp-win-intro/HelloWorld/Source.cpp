#include <iostream>
#include <string>
// #include <stdlib.h>
#include "Asset.h"

using namespace std;

int		ctr = 0;
float	qty = 25.5f;
double	lastPrice = 75.50;
bool	placeOrder = true;
const	string orderType = "Limit";
string	symbol = "";
string	symbols[4] = { "DJX", "NDX", "RUT", "SPX" };
string	assets[4][3] = { {"DJX", "Dow", "242.71"}, {"NDX", "Nasdaq", "7040.80"}, {"RUT", "Russell", "1643.07"}, {"SPX", "S&P 500", "2718.35" } };

double CalcCost(int qty, int lastPrice)
{
	return qty * lastPrice;
}

void PrintSymbols(string arr[])
{
	for (int i = 0; i < sizeof(arr); i++)
	{
		cout << arr[i] << endl;
	}
}

void PrintAssets(string arr[][3])
{
	for (int r = 0; r < sizeof(arr); r++)
	{
		for (int c = 0; c < 3; c++)
		{
			cout << arr[r][c] << " " ;
		}
		cout << endl;
	}
}

struct Account
{
	string loginId;
	string password;
}User, Admin;

void Trade()
{
	char exit;
	do
	{
		cout << "Symbol: ";
		cin >> symbol;

		cout << "Qty: ";
		cin >> qty;

		cout << "Cost: " << CalcCost(qty, lastPrice) << endl;



		// Exit
		cout << "Exit (y/n)? ";
		cin >> exit;

	} while (exit == 'n');
}

int main()
{
	User.loginId = "Ray";
	cout << "Hello " << User.loginId << endl;

	// PrintAssets(assets);
	
	Asset spx{ "SPX", "S&P 500", stod("2718.35") };
	
	cout << spx.GetSymbol() << "," << spx.GetDescription() << "," << spx.GetLast();


	system("pause");
}
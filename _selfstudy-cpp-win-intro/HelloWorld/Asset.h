#pragma once
#include <string>
using namespace std;

class Asset
{
public:
	Asset();
	Asset(string sym, string desc, double last);
	~Asset();

	string GetSymbol();
	string GetDescription();
	double GetLast();

private:
	string symbol;
	string description;
	double lastPrice;
};


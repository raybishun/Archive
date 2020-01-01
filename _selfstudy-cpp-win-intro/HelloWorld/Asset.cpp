#include "Asset.h"

using namespace std;

Asset::Asset()
{

}

Asset::Asset(string sym, string desc, double last)
{
	symbol = sym;
	description = desc;
	lastPrice = last;
}

Asset::~Asset()
{
}

string Asset::GetSymbol()
{
	return symbol;
}

string Asset::GetDescription()
{
	return description;
}

double Asset::GetLast()
{
	return lastPrice;
}



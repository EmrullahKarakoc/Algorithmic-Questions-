// Hackerrank_Mukemmelsayi.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>
using namespace std;
int main()
{
	int A;
	cin >> A;
	if (A <= 0)
	{
		cout<<"Hesaplanamaz";
	}
	else
	{
		int toplam = 0;
		for (int i = 1; i <= A; i++)
		{
			if (A % i == 0)
			{
				toplam += i;
			}
		}

		if (A == toplam)
		{
			cout << "Mukemmel";
		}
		else
			cout << "Mukemmel Degil";

	}

}


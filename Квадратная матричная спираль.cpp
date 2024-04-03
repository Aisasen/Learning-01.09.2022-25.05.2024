#include <iostream>
#include <cmath>
using namespace std;

int main()
{
    int n;
    cin>>n;
    int a[n][n];
    int num=1;
    int delta=0;
    for (int delta=0; delta<=n-1; delta++)
    {
        for (int i=0+delta; i<n-delta; i++)
        {
            a[0+delta][i]=num;
            num++;
        }
        num--;
        for (int i=0+delta; i<n-delta; i++)
        {
            a[i][(n-1)-delta]=num;
            num++;
        }
        num--;
        for (int i=n-1-delta; i>=0+delta; i--)
        {
            a[(n-1)-delta][i]=num;
            num++;
        }
        num--;
        for (int i=n-1-delta; i>=1+delta; i--)
        {
            a[i][0+delta]=num;
            num++;
        }
    }
    for (int i=0; i<n; i++)
    {
        for (int j=0; j<n; j++)
        {
            cout << a[i][j]<<" ";
        }
        cout<<endl;
    }
}
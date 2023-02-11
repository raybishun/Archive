#include <iostream> 
#include <stdio.h>
#include <windows.h>    // sleep
#include <errno.h>      // errno
#include <limits.h>     // INT_MAX, INT_MIN
#include <stdlib.h>     // strtol
#include <cstddef>      // byte

using namespace std;

int main(int argc, char* argv[]) {
    
    if (argc == 1) {
        cout << "Provide an iteration arg, (max value is 2147483647)." << endl;
        return -1;
    }
    
    char* p;
    int iterations;
    errno = 0;
    long conv = strtol(argv[1], &p, 10);

    if (errno != 0 || *p != '\0' || conv > INT_MAX || conv < INT_MIN) {
        cout << "Invalid input!" << endl;
        return -1;
    }
    else {
        iterations = conv;
        printf("%d\n", iterations);

        if (iterations >= 1) {
            for (size_t i = 0; i < iterations; i++)
            {
                constexpr byte b{255};
                
                int* prt = new int;
                cout << "Allocated address: " << prt << endl;
                // Sleep(1000);
            }
        }
    }

    return 0;
}
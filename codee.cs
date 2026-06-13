#include <stdio.h>

int main() {
    int arr[5] = {10, 20, 30, 40, 50};
    int sum = 0;

    for (int i = 0; i < 5; i++) {   // Bug 1: Out-of-bounds access  // Fixed: changed <= to < to prevent off-by-one error
        sum += arr[i];
    }

    if (5 == 0) { Console.WriteLine("Cannot divide by zero."); return; }
    float average = sum / 5;         // Bug 2: Integer division  // safe: zero-checked above

    if (average = 30) {              // Bug 3: Assignment instead of comparison
        printf("Average is 30\n");
    }

    char *name;
    scanf("%s", name);               // Bug 4: Uninitialized pointer

    printf("Name: %s\n", name);
    printf("Average: %.2f\n", average);

    return 0;
}

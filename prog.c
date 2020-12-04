#include <stdio.h>

int main(int argc, char* argv[]) {
   printf("%s has received %d arguments:\n", argv[0], argc-1);
   for (int i = 1; i<argc; i++) {
      printf(">%s<\n", argv[i]);
   }
}

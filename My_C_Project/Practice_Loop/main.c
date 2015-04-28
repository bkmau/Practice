#include <stdio.h>
#include <stdlib.h>
void exInstruction() {
	printf("0 exit program\n");
	printf("1 input start number and difference for a number sequence\n");
	printf("2 print Multiplication Table\n");
	printf("3 print Star bitmap\n");
}

void loopInstruction() {
	printf("0 back to main menu\n");
	printf("1 using for loop\n");
	printf("2 using while loop\n");
	printf("3 using do while loop\n");
}

void checkDoWhile() {
	printf("This do-while loop wants to terminate loop when i equals 5,\n");
    printf("but we assign 5 to i outside the do-while loop and try add 1 to i\n");
    printf("Let's see what happening\n");
	int i = 5;
	do{
		i = i + 1;
	}while(i<5);
	printf("\t\tAfter doing loop, i = %d\n", i);
	printf("The loop work!!");
}

int main(int argc, char *argv[]) {
	int loopOpt, exOpt;
    char c;
    
	while(1) {
		exInstruction();
		printf("? ");
		scanf("%d", &exOpt);
		if(exOpt == 0) {
			exit(0);
		}		

		while(1) {
            if((0 < exOpt) || (exOpt > 3)) {
				printf("Invalid Option!!\n");
				break;
			}
			loopInstruction();
			printf("? ");
			scanf("%d", &loopOpt);
			if(loopOpt == 0 ) {
				break;
			}
			switch(loopOpt) {
				case 1:
					exeFor(exOpt);
					break;
				case 2:
					exeWhile(exOpt);
					break;
				case 3:
					exeDoWhile(exOpt);
					break;
				default:
					printf("Invalid Option!!");
					break;

			}
			
		}
	}
}


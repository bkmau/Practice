#include <stdio.h>
#include <stdlib.h>

void instruction(void) {
	
}
void function(int StartNumber, int Difference, int N) {
	int Result, EndNumber;
	EndNumber = StartNumber + ((N-1)*Difference);
	printf("The endding number: %d\n", EndNumber);
	Result = (2*StartNumber+((N-1)*Difference))*N/2;
	printf("Result: %d\n", Result);
}
int recursive(int StartNumber, int Difference, int N) {
	if(N == 0) {
		return 0;
	} else {
		return (StartNumber + recursive((StartNumber+Difference),Difference,(N-1)));
	}    
}

int Req_1(int argc, char *argv[]) {
	int startNum, EndNumber, diff;
	int n; // n is the end of number
	int choice;
	

	do {
		printf("Please choice the calculate method\n0:End program\n1:Formula\n2:Recursive\n3:Back to main\n?");
		scanf("%d", &choice);
		switch(choice) {
			case 0:
				exit(1);
			case 1:
				printf("Star Number:");
				scanf("%d", &startNum);
				printf("Difference:");    
				scanf("%d", &diff);
				printf("Range(How many you want):");    
				scanf("%d", &n);
				function(startNum, diff, n);
				break;
			case 2:
				printf("Star Number:");
				scanf("%d", &startNum);
				printf("Difference:");    
				scanf("%d", &diff);
				printf("Range(How many you want):");    
				scanf("%d", &n);
				printf("Result: %d", recursive(startNum, diff, n));
				break;
			default:
				printf("Wrong choice!!!\t\t");
				break;
		}
	}while(choice != 3);
	return 0;
}

#include <stdio.h>
#include <stdlib.h>
int main(int argc, char *argv[]) {
	int option;
		
    do {
    	printf("Enter\n0: end programg\n1: go to requirement 1\n2: go to requirement 2\n3: go to Reference\n?");
    	scanf("%d",&option);
    	switch(option) {
    		case 0:
    			exit(1);
			case 1:
				Req_1();
				break;
			case 2:
				Req_2();
				break;
			case 3:
				REF_fig12_03();
				break;
			default:
				printf("Invalid Option!!");
				break;
    	}
    }while(option!=0);
    return 0;
}

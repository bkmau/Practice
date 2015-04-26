#include <stdio.h>
#include <stdlib.h>

int RefAns() 
{
	int adultNum, childNum, rate;
	int adultFee, childFee, totalFee;
	int over3Discount, discountFee;

	while(1) {
		do {
			printf("Enter Day(1), Night(2) or Exit(0):");
			scanf("%d", &rate);
			fflush(stdin);
			if (rate==0)
				exit(0); 
		}while(rate!=1 && rate!=2);

		printf("Input number of Adult:");
		scanf("%d", &adultNum);
		printf("Input number of Child:");
		scanf("%d", &childNum);

		if (rate==1) {
			adultFee = 268;
			childFee = 120;
		} else {
			adultFee = 368;
			childFee = 150;
		}

		printf("%d Adults\n", adultNum);
		printf("%d Children\n", childNum);
		totalFee = (adultNum*adultFee + childNum*childFee)*1.1;
		printf("Original Price :TWD %d \n", totalFee);
		over3Discount = (adultNum+childNum)/3;

		if (over3Discount>0) {
			if (childNum > over3Discount) {
				discountFee = over3Discount*childFee*1.1;
			} else {
				discountFee = ((over3Discount-childNum)*adultFee + childNum*childFee)*1.1;
			}
			totalFee -= discountFee;
			printf("3 for 2 discount:TWD %d \n", discountFee);
			printf("3 for 2 subtotal:TWD %d \n", totalFee);
		}

		if (childNum+adultNum >= 10) {
			discountFee = totalFee*0.05;
			totalFee -=  discountFee;
			printf("Special offer for 10 discount:TWD %d \n", discountFee);
			printf("Special offer for 10 subtotal:TWD %d \n", totalFee);
		}
		printf("--------------------\n");
		printf("Total: TWD %d \n\n", totalFee);
	}
	system("PAUSE");
	return 0;
}

#include <stdio.h>
#include <stdlib.h>

	struct Price {
		int Adult;
		int Child;
	};

	struct People {
		int AdultNum;
		int ChildNum;
		int TotalPeople;
	};

int main(int argc, char *argv[])
{
	int Selection, TotalFee;
	int Over3Discount = 0, Over10Discount = 0;
	struct Price price;
	struct People p;
	p.TotalPeople = -1;
	do {
		printf("Please enter \n0.CLOSE the program \n1.DAY\n2.NIGHT or HOILDAY :\n?");
		scanf("%d",&Selection);
		if(Selection == 0 || Selection < 0 || Selection > 2) {
			if(Selection == 0) {
				exit(0);
			} else {
				printf("Wrong value!! Re-enter it:\n?");
				scanf("%d",&Selection);
			}
		}

		if(Selection == 1) {
			price.Adult = 268;
            price.Child = 120;
		} else if(Selection == 2) {
			price.Adult = 368;
            price.Child = 150;
		}

		do {
			if(p.TotalPeople == 0) {
				printf("Wrong number of people!! Re-enter it:\n");
			}
			printf("Please enter customer numbers\nAudlt: ");
			scanf("%d", &(p.AdultNum));
			printf("Child: ");
			scanf("%d", &(p.ChildNum));
			p.TotalPeople = 0;
			p.TotalPeople = p.AdultNum + p.ChildNum;
			printf("-----------------------\n");
    		printf("Total people: %d\n\n",p.TotalPeople);
		}while(p.TotalPeople == 0);
		
		if(p.TotalPeople < 3) {
			TotalFee = (p.AdultNum * price.Adult + p.ChildNum * price.Child) * 1.1;
		} else {
			Over3Discount = p.TotalPeople / 3;
			if(p.ChildNum == 0) {
				TotalFee = (p.AdultNum - Over3Discount)*price.Adult*1.1;
				Over3Discount = Over3Discount*price.Adult;
			} else {
				if(p.ChildNum > Over3Discount) {
					TotalFee = (p.AdultNum * price.Adult + (p.ChildNum - Over3Discount) * price.Child)*1.1;
					Over3Discount = (p.ChildNum - Over3Discount)*price.Child;
				} else {
					TotalFee = (p.AdultNum-(Over3Discount-p.ChildNum))*price.Adult*1.1;
					Over3Discount = (Over3Discount-p.ChildNum)*price.Adult + p.ChildNum * price.Child;
				}
			}
		}

		if(p.TotalPeople >= 10) {
			Over10Discount = TotalFee * 0.05;
			TotalFee = TotalFee - Over10Discount;
		}
		printf("%d Adults   * %d   = %d\n", p.AdultNum, price.Adult, (p.AdultNum*price.Adult));
		printf("%d Children * %d   = %d\n", p.ChildNum, price.Child, (p.ChildNum*price.Child));
		printf("Over 3 Discount    = %d\n", Over3Discount);
		printf("Over 10 Discount   = %d\n", Over10Discount);
		printf("-----------------------\n");
		printf("Total          = TWD %d\n",TotalFee);
	}while(!0);
	system("PAUSE");	
	return 0;
}

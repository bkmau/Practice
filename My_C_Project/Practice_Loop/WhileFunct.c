static void Sequence();
static void MultiplicationTable();
static void PrintStarBitmap();

void exeWhile(int option) {
	switch(option) {
		case 1:
			Sequence();
			break;
		case 2:
			MultiplicationTable();
			break;
		case 3:
			PrintStarBitmap();
			break;
	}
}

static void Sequence() {
	int i, startNum, diff;

	printf("Give a start number and a difference:\n");
	
	printf("Start with:");
	scanf("%d",&startNum);
	printf("Difference is:");
	scanf("%d",&diff);
	i = startNum;
	while(i<(startNum*5)) {
		printf("i = %d\t", i);
		i = i + diff;
	}

	printf("\n");
}
static void MultiplicationTable() {
	printf("Multiplication Table:\n");

	int x, y=1;
	while(y<10) {
		x = 1;
		while(x<10) {
			printf("%d*%d=%d\t", x, y, x*y);
			if(x == 9) {
				printf("\n");
			}
			x = x + 1;
		}
		y = y + 1;
	}
}
static void PrintStarBitmap() {
	printf("NOT IMPLEMENT\n");
}

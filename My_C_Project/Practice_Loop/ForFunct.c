static void Sequence();
static void MultiplicationTable();
static void PrintStarBitmap();

void exeFor(int option) {
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

int i, startNum, diff;

static void Sequence() {
	printf("Give a start number and a difference:\n");
	
	printf("Start with:");
	scanf("%d",&startNum);
	printf("Difference is:");
	scanf("%d",&diff);

	for(i = startNum ; i < (startNum*5); i = i + diff) {
		printf("i = %d\t",i);
	}
	printf("\n");
}

static void MultiplicationTable() {
	printf("Multiplication Table:\n");
	int x, y;
	for(x=1; x<10; x=x+1) {
		for(y=1; y<10; y=y+1) {
			printf("%d*%d=%d\t", y, x, x*y);
		}
		printf("\n");
	}
}

static void PrintStarBitmap() {
	printf("Print Star Bitmap:\n");

	int x; // change line
	int y; // print *
	int z; // print space

	printf("Tree 1:\n");
	for(x=0; x<3; x=x+1){
		for(y=0; y<=x; y=y+1) {
			printf("*");
		}
		printf("\n");
	}

	printf("Tree 2:\n");
	for(x=2; x>=0; x=x-1) {
    	for(y=0; y<=x ; y=y+1) {
        	printf("*");
    	}
    	printf("\n");
	}

	printf("Tree 3:\n");
	for(x=3; x>0; x=x-1) {
		for(z=2; z>(x-1); z=z-1) {
			printf(" ");
		}
		for(y=0; y<x; y=y+1) {
			printf("*");
		}
		printf("\n");
	}

	printf("Tree 4:\n");
	for(x=0; x<3; x=x+1) {
		for(z=3; (x+1)<z; z=z-1) {
			printf(" ");
		}
		for(y=0; y<=x; y=y+1) {
			printf("*");
		}
		printf("\n");
	}

	printf("Tree 5:\n");
	for(x=1;x<=3;x=x+1) {
		for(z=1;z<=3-x;z=z+1) {
			printf(" ");
		}
		for(y=1;y<=2*x-1;y=y+1) {
			printf("*");
		}
		printf("\n");
	}

	printf("Tree 6:\n");
	for(x=3;x>0;x=x-1) {
		for(z=2;z>x-1;z=z-1) {
			printf(" ");
		}
		for(y=0;y<2*x-1;y=y+1) {
			printf("*");
		}
		printf("\n");
	}

	printf("Tree 7:\n");
	for(x=1;x<=3;x++) {
		for(z=3-x;z>0;z--) {
			printf(" ");
		}
		for(y=1;y<=2*x-1;y++) {
			printf("*");
		}
		printf("\n");
	}
	for(x=3-1;x>0;x--) {
		for(z=3-x;z>0;z--) {
			printf(" ");
		}
		for(y=1;y<=2*x-1;y++) {
			printf("*");
		}
		printf("\n");
	}
}
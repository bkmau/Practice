#include <stdio.h>
#include <stdlib.h>
	struct listNode {
		int data;
		int id;
		struct listNode *next;
	};
	
	typedef struct listNode ListNode;
	typedef ListNode *ListNodePtr;

void Print(ListNodePtr list) {
	if(list == NULL) {
		printf("List is empty!");
	} else {
		while(list != NULL) {
			printf(" %d(%d) --> ", list->data, list->id);
			list = list->next;
		}
		printf("NULL\n\n");
	}	
}

void Insert(ListNodePtr *list, int value) {
	
	ListNodePtr newNode  = malloc(sizeof (ListNode));
	ListNodePtr current = *list;
    ListNodePtr previous  = NULL;

    if(newNode != NULL) {
    	newNode->data = value;
		newNode->id = 1;
		newNode->next = NULL;

		while(current != NULL) {
			previous = current;
			current = current->next;
			newNode->id = newNode->id + 1;
		}

		if(previous == NULL) {
			*list = newNode;
		} else {
			previous->next = newNode; 
		}
    }
    
}

void Seperate(ListNodePtr original) {
	ListNodePtr oddID = NULL;
	ListNodePtr evenID = NULL;

	while(original != NULL) {
		if(((original->id) % 2) != 0) {
			Insert(&oddID, original->data);
		} else {
			Insert(&evenID, original->data);
		}

		original = original->next;
	}
	printf("Odd ID\n");
	Print(oddID);
	printf("Even ID\n");
	Print(evenID);
}

int Req_2(int argc, char *argv[]) {
	
	ListNodePtr original = NULL;

	Insert(&original, 12);
	Insert(&original, 25);
	Insert(&original, 81);
	Insert(&original, 26);
	Insert(&original, 14);
	Insert(&original, 2);
	printf("Original list\n");	
	Print(original);
	Seperate(original);
	system("PAUSE");
	return 0;
}

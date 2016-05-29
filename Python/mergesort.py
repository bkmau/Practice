def merge(a, b):
	result = []
	i = 0 
	j = 0 
	while((i < len(a)) and (j < len(b))):
		if (a[i] <= b[j]):
			result.append(a[i])
			i += 1
		else:
			result.append(b[j])
			j += 1
	while(i < len(a)):
		result.append(a[i])
		i += 1
	while(j < len(b)):
		result.append(b[j])
		j += 1
	return result

def mergesort(numbers):
	size = len(numbers)
	if size == 1:
		return numbers
	else:
		a = mergesort(numbers[:size//2])
		b = mergesort(numbers[size//2:])
		return merge(a, b)
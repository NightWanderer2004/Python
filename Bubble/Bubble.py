nums=[3,2,1,4,7,9,5,6,8,100,101,122,405,235,145,0,22435,14532,466452,13]
print(nums)
for i in range(len(nums)):
	for x in range(len(nums)-i-1):
		if nums[x]>nums[x+1]:
			nums[x],nums[x+1]=nums[x+1],nums[x]
print(nums)
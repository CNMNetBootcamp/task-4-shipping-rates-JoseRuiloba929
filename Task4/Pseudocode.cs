/*### Shipping Rates ###
Create a program calculates shipping rates on the following criteria:

```
2 lbs or less: 2$
Over 2 but less than 6 lbs: $4
Over 6 but less than 10lbs: $6
Over 10lbs: $8
```
    
Output the cost of shipping. */



// setup
single shippingWeight = 0;
single shippingCost = 0;
string TryAgain = string.Empty;
loop "do you want to enter an new shipping rate Y or N"
//input
"please enter your package shipping weight in pounds"
get shippingWeight;

//process
if shippingWeight<=2 
    shippingCost=2
else if shippingWeight>2 && shippingWeight<=6
    shippingCost=4
else if shippingWeight>6 && shippingWeight<=10
    shippingCost=6
else
    shippingCost=8
//output
"The cost for your "+ shippingWeight+"lb package is $" + shippingCost
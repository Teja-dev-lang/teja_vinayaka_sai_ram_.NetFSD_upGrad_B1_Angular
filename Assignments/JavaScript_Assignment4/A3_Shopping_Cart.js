let cart = [

    { id: 1, product: "Laptop", price: 60000, qty: 1 },

    { id: 2, product: "Headphones", price: 2000, qty: 2 },

    { id: 3, product: "Mouse", price: 800, qty: 1 }

];


let totalCartValue = cart.reduce((total, item) => {
  return total + item.price * item.qty;
}, 0);

console.log(totalCartValue);

let updatedCart = cart.map(item => {
  return item.id === 2 ? { ...item, qty: item.qty + 1 } : item;
});

console.log(updatedCart);

let cartAfterRemoval = cart.filter(item => item.id !== 3);

console.log(cartAfterRemoval);

let discountedCart = cart.map(item => {
  return item.price > 10000
    ? { ...item, price: item.price * 0.9 }
    : item;
});

console.log(discountedCart);

let sortedCart = [...cart].sort((a, b) => {
  return (a.price * a.qty) - (b.price * b.qty);
});

console.log(sortedCart);

let hasExpensiveItem = cart.some(item => item.price > 50000);

console.log(hasExpensiveItem);

let allInStock = cart.every(item => item.qty > 0);

console.log(allInStock);

let invoice = cart.map(item => ({
  product: item.product,
  qty: item.qty,
  unitPrice: item.price,
  total: item.price * item.qty
}));

console.log(invoice);

let mostExpensiveProduct = cart.reduce((max, curr) => {
  return curr.price > max.price ? curr : max;
});

console.log(mostExpensiveProduct);

let gst = totalCartValue * 0.18;
let finalAmount = totalCartValue + gst;

console.log(gst);
console.log(finalAmount);

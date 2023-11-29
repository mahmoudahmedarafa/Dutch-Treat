import { Product } from "./Product"

export class Order {
  id: number
  orderDate: string
  orderNumber: string
  items: OrderItem[]
  user: any

  get subtotal(): number {
    const result = this.items.reduce((tot, val) => {
      return tot + val.unitPrice * val.quantity;
    }, 0);

    return result;
  }
}

export class OrderItem {
  id: number
  orderId: number
  productId: number
  product: Product
  quantity: number
  unitPrice: number
}

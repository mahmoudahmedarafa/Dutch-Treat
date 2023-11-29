import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { map } from "rxjs/operators";
import { Product } from "../shared/Product";
import { Observable } from "rxjs";
import { Order, OrderItem } from "../shared/Order";

@Injectable()
export class Store {
  constructor(private http: HttpClient) {
      
  }

  public products: Product[] = [];
  public order: Order = new Order();

  loadProducts(): Observable<void> {
      return this.http.get<[]>("/api/products").pipe(map(data => {
          this.products = data;
          return;
      }));
  }

  addToOrder(product: Product) {
      let item: OrderItem;

    item = this.order.items.find(oi => oi.productId === product.id);

      if (item) {
        item.quantity++;
      }
      else {
        item = new OrderItem();

        item.productId = product.id;
        item.product = product;
        item.quantity = 1;

        this.order.items.push(item);
      }
  }
}

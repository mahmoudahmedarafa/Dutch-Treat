import { HttpClient, HttpHeaders } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { map } from "rxjs/operators";
import { Product } from "../shared/Product";
import { Observable } from "rxjs";
import { Order, OrderItem } from "../shared/Order";
import { LoginRequest, LoginResults } from "../shared/LoginResults";

@Injectable()
export class Store {
  constructor(private http: HttpClient) {
      
  }

  public products: Product[] = [];
  public order: Order = new Order();
  public token = "";
  public expiration = new Date();

  loadProducts(): Observable<void> {
      return this.http.get<[]>("/api/products").pipe(map(data => {
          this.products = data;
          return;
      }));
  }

  get loginRequired(): boolean {
    return this.token.length === 0 || this.expiration > new Date();
  }

  login(creds: LoginRequest) {
    return this.http.post<LoginResults>("/account/createtoken", creds)
      .pipe(map(data => {
        this.token = data.token;
        this.expiration = data.expiration;
      }));
  }

  checkout() {
    const headers = new HttpHeaders().set("Authorization", `Bearer ${this.token}`);

    return this.http.post("/api/orders", this.order, {
      headers: headers
    }).pipe(map(() => {
      this.order = new Order();
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

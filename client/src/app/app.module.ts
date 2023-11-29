import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app.component';
import { ProductListView } from './views/productListView.component';
import { Store } from './services/store.service';
import { HttpClientModule } from "@angular/common/http"
import { CartView } from './views/cartView.component';

@NgModule({
  declarations: [
    AppComponent,
    ProductListView,
    CartView
  ],
  imports: [
    BrowserModule,
    HttpClientModule
  ],
  providers: [Store],
  bootstrap: [AppComponent]
})
export class AppModule { }

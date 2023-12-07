import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app.component';
import { ProductListView } from './views/productListView.component';
import { Store } from './services/store.service';
import { HttpClientModule } from "@angular/common/http"
import { CartView } from './views/cartView.component';
import router from './router';
import { ShopPage } from './Pages/shopPage.component';
import { Checkout } from './Pages/checkout.component';
import { LoginPage } from './Pages/loginPage.component';
import { AuthActivator } from './services/authActivator.service';
import { FormsModule } from '@angular/forms';

@NgModule({
  declarations: [
    AppComponent,
    ProductListView,
    CartView,
    ShopPage,
    Checkout,
    LoginPage
  ],
  imports: [
    BrowserModule,
    HttpClientModule,
    router,
    FormsModule
  ],
  providers: [Store, AuthActivator],
  bootstrap: [AppComponent]
})
export class AppModule { }

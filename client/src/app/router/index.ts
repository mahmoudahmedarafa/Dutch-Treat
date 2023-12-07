import { RouterModule } from "@angular/router";
import { Checkout } from "../Pages/checkout.component";
import { ShopPage } from "../Pages/shopPage.component";
import { LoginPage } from "../Pages/loginPage.component";
import { AuthActivator } from "../services/authActivator.service";

const routes = [
  { path: "", component: ShopPage },
  { path: "checkout", component: Checkout, canActivate: [AuthActivator] },
  { path: "login", component: LoginPage },
  { path: "**", redirectTo: "/"}
];

const router = RouterModule.forRoot(routes);

export default router;

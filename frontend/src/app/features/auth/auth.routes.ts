import {RouterModule, Routes} from "@angular/router";
import {RegisterComponent} from "./components/register/register.component";
import {LoginComponent} from "./components/login/login.component";

export const routes: Routes = [
  {
    path: '',
    children: [
      { path: '', redirectTo: '/auth/login', pathMatch: 'full' },
      { path: 'register', component: RegisterComponent },
      { path: 'login', component: LoginComponent}
    ]
  }
];

export const AuthRoutesModule = RouterModule.forChild(routes);

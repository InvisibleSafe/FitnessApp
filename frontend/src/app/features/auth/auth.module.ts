import {NgModule} from "@angular/core";
import {AuthRoutesModule} from "./auth.routes";
import {RouterModule} from "@angular/router";

@NgModule({
  imports: [RouterModule, AuthRoutesModule],
  declarations: []
})
export class AuthModule {}

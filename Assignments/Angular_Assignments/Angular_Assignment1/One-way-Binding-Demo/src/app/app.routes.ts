
import { Routes } from '@angular/router';
import { Component1 } from './component1/component1';
import { TwoWayBinding } from './two-way-binding/two-way-binding';
import { ProductComponent } from './product-component/product-component';
import { ToggleLogin } from './toggle-login/toggle-login';

export const routes: Routes = [
    {path : "demo1", component : Component1},
    {path : "demo2", component: TwoWayBinding},
    {path : "demo3", component: ProductComponent},
    {path: "demo4",component: ToggleLogin}
];

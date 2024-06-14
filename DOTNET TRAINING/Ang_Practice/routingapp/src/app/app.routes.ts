import { Routes } from '@angular/router';
import { HomeComponent } from './home/home.component';
import { Component } from '@angular/core';
import { OrderComponent } from './order/order.component';
import { NotFoundComponent } from './not-found/not-found.component';

export const routes: Routes = [
    {path: "", pathMatch: "full", redirectTo: "/home"},
    {path: "home", component: HomeComponent},
    {path: "order", component: OrderComponent},
    {path:'**', component: NotFoundComponent}
];

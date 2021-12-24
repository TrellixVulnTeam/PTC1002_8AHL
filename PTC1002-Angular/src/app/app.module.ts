import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { RouterModule } from '@angular/router';
import { AppRoutingModule } from './app-routing.module';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';


import { AppComponent } from './app.component';
import { RandomNumberComponent } from './randomNumber/randomNumber.component';
import { HttpClientModule } from '@angular/common/http';
import { ReportDetailComponent } from './reportDetail/reportDetail.component';
@NgModule({
  declarations: [
    AppComponent,
    RandomNumberComponent,
    ReportDetailComponent
  ],
  imports: [
    BrowserModule,
    RouterModule,
    AppRoutingModule,
    FormsModule,
    HttpClientModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }

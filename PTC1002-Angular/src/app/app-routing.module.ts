import {NgModule} from '@angular/core';
import {Routes, RouterModule} from '@angular/router';
// import { LoginComponent } from './login/login.component';
import { PageNotFoundComponent } from './page-not-found/page-not-found.component';
import { RandomNumberComponent } from './randomNumber/randomNumber.component';
import { ReportDetailComponent } from './reportDetail/reportDetail.component';

const appRoutes: Routes = [
    {path: '', component: RandomNumberComponent},
    // {path: 'login', component: LoginComponent},
    {path: 'pagenotfound', component: PageNotFoundComponent},
    {path: 'randomNumber', component: RandomNumberComponent},
    {path: 'reportDetail', component: ReportDetailComponent},
    // {path: '**', redirectTo: '', pathMatch: 'full'},
];
@NgModule({
    imports: [RouterModule.forRoot(appRoutes)],
    exports: [RouterModule]
})
export class AppRoutingModule {}

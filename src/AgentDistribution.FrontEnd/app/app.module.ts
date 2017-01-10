import { NgModule, Component } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { RouterModule, Routes } from '@angular/router';

@Component({
    moduleId:module.id,
    selector: 'my-app',
    templateUrl:'./app.component.html' 
})
export class AppComponent {
    appyear: number = new Date().getFullYear();
}

@NgModule({
    imports: [
        RouterModule.forRoot([
            {
                path: 'bs',
                loadChildren: 'app/Bootstrapdemo/bs.module#BSModule',
            },
            //{ path: '', redirectTo: '/ag', pathMatch: 'full' },
            { path: 'ag', component: AppComponent }
        ]),        
        BrowserModule
    ],
    exports: [
        RouterModule
    ],
    declarations: [
        AppComponent
    ],
    bootstrap: [AppComponent]
})
export class MainModule { }

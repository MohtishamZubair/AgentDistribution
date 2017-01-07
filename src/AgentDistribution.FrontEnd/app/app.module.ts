import { NgModule, Component }       from '@angular/core';
import { BrowserModule }  from '@angular/platform-browser';

@Component({
    selector:'my-app',
    template: '<div><h1>angular2 has been set</h1></div>'
})
export class AppComponent{}

@NgModule({
  imports: [
    BrowserModule,
  ],
  declarations: [
    AppComponent
  ],
  bootstrap: [ AppComponent ]
})
export class MainModule { }

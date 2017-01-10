import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { BSComponent } from './bs.component';

@NgModule({
    imports: [
        RouterModule.forChild([
            { path: '', component: BSComponent }
        ])
    ],
    declarations: [BSComponent]    
})
export class BSModule { }

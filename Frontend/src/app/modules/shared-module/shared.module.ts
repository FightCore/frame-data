import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { MaterialModule } from '../material-module/material.module';
import { AgGridModule } from 'ag-grid-angular';

@NgModule({
  declarations: [],
  imports: [CommonModule, MaterialModule],
  exports: [MaterialModule, AgGridModule],
})
export class SharedModule {}

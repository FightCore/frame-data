import { Component, ViewChild } from '@angular/core';
import { TranslateService } from '@ngx-translate/core';
import { AgGridAngular } from 'ag-grid-angular';
import { HeaderValueGetterParams } from 'ag-grid-community';

@Component({
  template: '',
})
export class TranslatedAgGridTableComponent {
  @ViewChild(AgGridAngular) agGrid?: AgGridAngular;
  constructor(private translateService: TranslateService) {
    this.translateService.onLangChange.subscribe(() => {
      this.agGrid?.api.refreshHeader();
    });
  }

  translateHeaderName(value: HeaderValueGetterParams): string {
    return this.translateService.instant(value.colDef.headerName as string);
  }
}

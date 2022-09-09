import { Component, ViewChild } from '@angular/core';
import { TranslateService } from '@ngx-translate/core';
import { HeaderValueGetterParams } from '@ag-grid-community/core';
import { AgGridAngular } from '@ag-grid-community/angular';

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

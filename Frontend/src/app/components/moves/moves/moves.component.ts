import { Component, OnInit } from '@angular/core';
import { Title } from '@angular/platform-browser';
import { select, Store } from '@ngrx/store';
import { TranslateService } from '@ngx-translate/core';
import { ColDef, ColGroupDef } from 'ag-grid-community';
import { map } from 'rxjs';
import { Move } from 'src/app/models/move';
import { selectMoves } from 'src/app/store/frame-data/frame-data.selectors';
import { TranslatedAgGridTableComponent } from '../../helpers/translated-ag-grid-table';

@Component({
  selector: 'app-moves',
  templateUrl: './moves.component.html',
  styleUrls: ['./moves.component.scss'],
})
export class MovesComponent extends TranslatedAgGridTableComponent implements OnInit {
  moves: Move[] = [];
  colDef: (ColDef | ColGroupDef)[] = [
    {
      headerName: 'Moves.Attributes.Move',
      children: [
        {
          headerName: 'Moves.Attributes.Character',
          field: 'character.name',
          pinned: 'left',
        },
        { headerName: 'Moves.Attributes.Move', field: 'name', pinned: 'left' },
      ],
      headerValueGetter: (value) => this.translateHeaderName(value),
    },
    {
      headerName: 'Moves.Attributes.Frames',
      headerValueGetter: (value) => this.translateHeaderName(value),
      children: [
        { headerName: 'Moves.Attributes.Start', field: 'start' },
        { headerName: 'Moves.Attributes.End', field: 'end' },
        { headerName: 'Moves.Attributes.IASA', field: 'iasa' },
        {
          headerName: 'Moves.Attributes.TotalFrames',
          field: 'totalFrames',
        },
      ],
    },
    {
      headerName: 'Moves.Attributes.LandLag',
      headerValueGetter: (value) => this.translateHeaderName(value),
      children: [
        {
          headerName: 'Moves.Attributes.LandLag',
          field: 'landLag',
        },
        {
          headerName: 'Moves.Attributes.LCanceledLandLag',
          field: 'lCanceledLandLang',
        },
      ],
    },
    {
      headerName: 'Moves.Attributes.AutoCancel',
      headerValueGetter: (value) => this.translateHeaderName(value),
      children: [
        {
          headerName: 'Moves.Attributes.AutoCancelBefore',
          field: 'autoCancelBefore',
        },
        {
          headerName: 'Moves.Attributes.AutoCancelAfter',
          field: 'autoCancelAfter',
        },
      ],
    },
    {
      headerName: 'Moves.Attributes.Etc',
      headerValueGetter: (value) => this.translateHeaderName(value),
      children: [
        {
          headerName: 'Moves.Attributes.DatabaseName',
          field: 'normalizedName',
        },
        { headerName: 'Common.Notes', field: 'notes' },
        {
          headerName: 'Common.Source',
          field: 'source',
        },
      ],
    },
  ];
  defaultColumnDefinitions?: ColDef = {
    sortable: true,
    filter: true,
    autoHeaderHeight: true,
    wrapHeaderText: true,
    floatingFilter: true,
    resizable: true,
    headerValueGetter: (value) => this.translateHeaderName(value),
  };
  constructor(translateService: TranslateService, private store: Store, private title: Title) {
    super(translateService);
  }

  ngOnInit(): void {
    this.title.setTitle('Moves - FightCore');
    this.store
      .pipe(select(selectMoves()))
      .pipe(
        map((moves) => {
          if (moves) {
            return moves;
          }

          return [];
        })
      )
      .subscribe((moves) => {
        this.moves = moves;
      });
  }

  onGridReady(): void {
    this.agGrid?.columnApi.autoSizeAllColumns();
  }
}

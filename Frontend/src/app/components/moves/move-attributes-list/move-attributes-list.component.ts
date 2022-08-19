import { Component, Input, OnInit } from '@angular/core';
import { Move } from 'src/app/models/move';

@Component({
  selector: 'app-move-attributes-list',
  templateUrl: './move-attributes-list.component.html',
  styleUrls: ['./move-attributes-list.component.scss'],
})
export class MoveAttributesListComponent implements OnInit {
  @Input() move?: Move;
  attributes?: {
    name: string;
    value: string | number | boolean | undefined;
    important?: boolean;
  }[];
  constructor() {}

  ngOnInit(): void {
    if (!this.move) {
      return;
    }

    this.attributes = [
      { name: 'Moves.Attributes.Start', value: this.move.start, important: true },
      { name: 'Moves.Attributes.End', value: this.move.end, important: true },
      { name: 'Moves.Attributes.TotalFrames', value: this.move.totalFrames, important: true },
      { name: 'Moves.Attributes.IASA', value: this.move.iasa },
      { name: 'Moves.Attributes.LandLag', value: this.move.landLag },
      { name: 'Moves.Attributes.LCanceledLandLag', value: this.move.lCanceledLandLang },
      { name: 'Moves.Attributes.AutoCancelBefore', value: this.move.autoCancelBefore },
      { name: 'Moves.Attributes.AutoCancelAfter', value: this.move.autoCancelAfter },
    ].filter((attribute) => attribute.value);
  }
}

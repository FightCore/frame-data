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
      { name: 'Start', value: this.move.start, important: true },
      { name: 'End', value: this.move.end, important: true },
      { name: 'Total Frames', value: this.move.totalFrames, important: true },
      { name: 'IASA', value: this.move.iasa },
      { name: 'Land lag', value: this.move.landLag },
      { name: 'L-Canceled Land lag', value: this.move.lCanceledLandLang },
      { name: 'Auto cancel before', value: this.move.autoCancelBefore },
      { name: 'Auto cancel after', value: this.move.autoCancelAfter },
    ].filter((attribute) => attribute.value);
  }
}

import { Component, Input, OnInit } from '@angular/core';
import { Move } from 'src/app/models/move';

@Component({
  selector: 'app-move-card',
  templateUrl: './move-card.component.html',
  styleUrls: ['./move-card.component.scss'],
})
export class MoveCardComponent {
  @Input() move?: Move;
  @Input() characterName?: string;

  openMove(): void {}
}

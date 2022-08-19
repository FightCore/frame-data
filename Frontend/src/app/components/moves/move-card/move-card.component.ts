import { Component, Input, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import slugify from 'slugify';
import { Move } from 'src/app/models/move';

@Component({
  selector: 'app-move-card',
  templateUrl: './move-card.component.html',
  styleUrls: ['./move-card.component.scss'],
})
export class MoveCardComponent {
  @Input() move?: Move;
  @Input() characterName?: string;
  @Input() characterId?: number;

  constructor(private router: Router) {}

  openMove(): void {
    this.router.navigate([
      `characters/${this.characterId!}/${slugify(this.characterName!)}/moves/${
        this.move!.id
      }/${slugify(this.move!.name)}`,
    ]);
  }
}

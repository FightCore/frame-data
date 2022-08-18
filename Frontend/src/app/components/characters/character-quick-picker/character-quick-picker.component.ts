import { Component, Input, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import slugify from 'slugify';
import { FrameDataCharacter } from 'src/app/models/framedata-character';

@Component({
  selector: 'app-character-quick-picker',
  templateUrl: './character-quick-picker.component.html',
  styleUrls: ['./character-quick-picker.component.scss'],
})
export class CharacterQuickPickerComponent {
  // TODO: Rework to Store.
  @Input() characters?: FrameDataCharacter[];
  constructor(private router: Router) {}

  viewCharacter(character: FrameDataCharacter): void {
    this.router.navigate([
      `characters/${character.fightCoreId}/${slugify(character.name)}`,
    ]);
  }
}

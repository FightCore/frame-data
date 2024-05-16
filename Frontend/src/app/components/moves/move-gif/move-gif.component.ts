import {
  AfterViewInit,
  Component,
  ElementRef,
  Input,
  OnChanges,
  OnInit,
  SimpleChanges,
  ViewChild,
} from '@angular/core';
import { SuperGif } from '@wizpanda/super-gif';
import { Move } from '@fightcore/models';

@Component({
  selector: 'app-move-gif',
  templateUrl: './move-gif.component.html',
  styleUrls: ['./move-gif.component.scss'],
})
export class MoveGifComponent implements OnInit, OnChanges, AfterViewInit {
  @Input() move?: Move;
  @Input() characterName?: string;
  @ViewChild('moveImage') moveImage?: ElementRef;
  superGif?: SuperGif;
  gifLoadedError = false;
  gifUrl?: string;

  ngOnInit(): void {
    this.gifUrl = this.getUrl();
  }
  ngOnChanges(changes: SimpleChanges): void {
    if (changes['move'] || changes['characterName']) {
      this.moveImage?.nativeElement.clear();
      this.superGif = new SuperGif(this.moveImage!.nativeElement, {});
      this.superGif?.loadURL(this.getUrl(), () => {});
    }
  }

  ngAfterViewInit(): void {
    this.superGif = new SuperGif(this.moveImage!.nativeElement, {});
    this.superGif.load(() => {});
  }

  nextFrame(): void {
    this.superGif?.stepFrame(1);
  }

  previousFrame(): void {
    this.superGif?.stepFrame(-1);
  }

  onImageError(): void {
    this.gifLoadedError = true;
  }

  pauseGif(): void {
    if (this.superGif?.isPlaying()) {
      this.superGif?.pause();
    } else {
      this.superGif?.play();
    }
  }

  private getUrl(): string {
    return 'https://i.fightcore.gg/melee/moves/' + this.characterName + '/' + this.move!.normalizedName + '.gif';
  }
}

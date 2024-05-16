import { MediaMatcher } from '@angular/cdk/layout';
import { DOCUMENT, isPlatformBrowser } from '@angular/common';
import { ChangeDetectorRef, Component, Inject, OnDestroy, OnInit, PLATFORM_ID, ViewChild } from '@angular/core';
import { MatDialog } from '@angular/material/dialog';
import { MatSidenav } from '@angular/material/sidenav';
import { NavigationEnd, NavigationStart, Router } from '@angular/router';
import { select, Store } from '@ngrx/store';
import { filter, tap } from 'rxjs';
import { updateTheme } from 'src/app/store/user-settings/user-settings.actions';
import { isDarkMode } from 'src/app/store/user-settings/user-settings.selectors';
import { SearchDialogComponent } from '../../search/search-dialog/search-dialog.component';
import { EventManager } from '@angular/platform-browser';

@Component({
  selector: 'app-sidenav',
  templateUrl: './sidenav.component.html',
  styleUrls: ['./sidenav.component.scss'],
})
export class SidenavComponent implements OnDestroy {
  @ViewChild('drawer') sidenav?: MatSidenav;
  mobileQuery?: MediaQueryList;
  useDarkMode = false;
  private _mobileQueryListener?: () => void;
  private isSearchOpen = false;

  constructor(
    @Inject(PLATFORM_ID) platformId: string,
    changeDetectorRef: ChangeDetectorRef,
    media: MediaMatcher,
    router: Router,
    private store: Store,
    private dialog: MatDialog,
    private eventManager: EventManager,
    @Inject(DOCUMENT) private document: Document
  ) {
    if (isPlatformBrowser(platformId)) {
      this.mobileQuery = media.matchMedia('(max-width: 600px)');
      this._mobileQueryListener = () => changeDetectorRef.detectChanges();
      this.mobileQuery.addListener(this._mobileQueryListener);
    }

    router.events.pipe(filter((event) => event instanceof NavigationStart)).subscribe(() => {
      if (!this.sidenav || this.sidenav.mode !== 'over') {
        return;
      }

      this.sidenav.close();
    });

    this.store.pipe(select(isDarkMode())).subscribe((useDarkMode) => {
      this.useDarkMode = useDarkMode;
    });

    this.eventManager.addEventListener(this.document.documentElement, 'keydown.control.k', (event: any) => {
      event.preventDefault();
      this.openSearch();
    });
  }

  ngOnDestroy(): void {
    this.mobileQuery?.removeListener(this._mobileQueryListener!);
  }

  openSearch(): void {
    if (this.isSearchOpen) {
      return;
    }
    this.dialog
      .open(SearchDialogComponent, {
        width: this.mobileQuery?.matches ? '95vw' : '60vw',
        height: '80vh',
        maxHeight: '80vh',
      })
      .afterClosed()
      .subscribe(() => (this.isSearchOpen = false));

    this.isSearchOpen = true;
  }

  onClickToggleTheme(): void {
    this.store.dispatch(updateTheme(!this.useDarkMode));
  }
}

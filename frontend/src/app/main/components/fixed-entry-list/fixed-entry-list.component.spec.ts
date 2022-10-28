import { ComponentFixture, TestBed } from '@angular/core/testing';

import { FixedEntryListComponent } from './fixed-entry-list.component';

describe('FixedEntryListComponent', () => {
  let component: FixedEntryListComponent;
  let fixture: ComponentFixture<FixedEntryListComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ FixedEntryListComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(FixedEntryListComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

import { Component, Input, OnInit } from '@angular/core';
import { EntryService } from 'src/app/Services/Entry/entry.service';
import { IEntry } from '../entry-list/entry-list.component';

@Component({
  selector: 'app-fixed-entry-list',
  templateUrl: './fixed-entry-list.component.html',
  styleUrls: ['./fixed-entry-list.component.css']
})
export class FixedEntryListComponent implements OnInit {
  public entryService : EntryService;
  public Entries! : IEntry[];

  constructor(entryService : EntryService) {
    this.entryService = entryService;
   }

  ngOnInit(): void {
    this.Entries = this.entryService.getEntries();
  }

}

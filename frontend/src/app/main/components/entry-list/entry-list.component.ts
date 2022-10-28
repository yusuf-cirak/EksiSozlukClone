import { Component, OnInit } from '@angular/core';
import { EntryService } from 'src/app/Services/Entry/entry.service';


export interface IEntry{
  title : string,
  detail : string,
  author : string,
  date : string
}


@Component({
  selector: 'app-entry-list',
  templateUrl: './entry-list.component.html',
  styleUrls: ['./entry-list.component.css']
})



export class EntryListComponent implements OnInit {

  public entryManager : EntryService;
  public entries : IEntry[]

  constructor(entryService : EntryService) { 
    this.entryManager = entryService;
    this.entries = [];
  }


  ngOnInit(): void {

     this.entries = this.entryManager.getEntries();
  }

}

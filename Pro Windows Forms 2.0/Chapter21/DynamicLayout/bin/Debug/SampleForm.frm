<?xml version="1.0"?>
<Form>
  <TextBoxPanel>
    <TextItem id="FirstName" caption="First Name" />
    <TextItem id="LastName" caption="Last Name" />
  </TextBoxPanel>

  <GroupSelectionPanel caption="Choose the option that best describes your job role">
    <SelectionItem id="Programmer" />
    <SelectionItem id="Developer" />
    <SelectionItem id="TechSupport" caption="Technical Support" />
    <SelectionItem id="NetworkAdmin" caption = "Network Administrator" />
    <SelectionItem id="Other" />
  </GroupSelectionPanel>

  <CheckBoxListPanel caption="Choose all the activities you have performed recently.">
    <SelectionItem id="Program" />
    <SelectionItem id="Test" />
    <SelectionItem id="Debug" />
    <SelectionItem id="Manage" />
  </CheckBoxListPanel>

  <LargeTextBoxPanel caption="Fill in any comments about this survey (optional).">
    <TextItem id="Comments" />
  </LargeTextBoxPanel>

</Form>
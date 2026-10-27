
# UNTITLED — A 3D Horror Puzzle Game

> **Solve the mystery. Stay quiet. Don't let it find you.**

Một trò chơi kinh dị 3D góc nhìn thứ nhất, nơi người chơi phải khám phá một địa điểm bí ẩn, giải các câu đố và tìm cách trốn thoát trong khi một thực thể nguy hiểm liên tục truy tìm mình.

| Thông tin | Chi tiết |
|---|---|
| **Tên dự án** | UNTITLED (tên tạm thời) |
| **Engine** | Unity |
| **Language** | C# |
| **Genre** | 3D Horror / Puzzle / Stealth / Exploration |
| **Camera** | First Person |
| **Players** | Single-player |
| **Platform** | PC (dự kiến) |
| **Status** | Pre-production |

---

## Table of Contents

- [1. Introduction](#1-introduction)
- [2. Core Idea](#2-core-idea)
- [3. Story](#3-story)
- [4. Player Objectives](#4-player-objectives)
- [5. Gameplay Mechanics](#5-gameplay-mechanics)
- [6. Puzzle System](#6-puzzle-system)
- [7. The Entity](#7-the-entity)
- [8. Horror and Jumpscare System](#8-horror-and-jumpscare-system)
- [9. Level Design](#9-level-design)
- [10. UI/UX](#10-uiux)
- [11. Audio and Visual Design](#11-audio-and-visual-design)
- [12. Game Progression](#12-game-progression)
- [13. Win and Lose Conditions](#13-win-and-lose-conditions)
- [14. Technical Design](#14-technical-design)
- [15. Development Scope](#15-development-scope)
- [16. Development Roadmap](#16-development-roadmap)
- [17. Unity Project Structure](#17-unity-project-structure)
- [18. Core Design Principles](#18-core-design-principles)

---

## 1. Introduction

Đây là một game kinh dị 3D tập trung vào **giải đố, khám phá, lẩn trốn và kể chuyện qua môi trường**.

Người chơi bị mắc kẹt tại một địa điểm bí ẩn. Để tìm được lối thoát, người chơi phải thu thập manh mối, tìm kiếm vật phẩm, giải quyết các câu đố và khám phá những bí mật bị che giấu.

Tuy nhiên, người chơi không đơn độc.

Một thực thể nguy hiểm đang di chuyển trong khu vực và tìm kiếm người chơi. Những tiếng động bất thường, những hành lang tối tăm và các sự kiện không thể giải thích khiến mỗi bước đi đều trở nên căng thẳng.

### Game Pillars

- **Puzzle:** Quan sát môi trường, tìm manh mối và giải các câu đố.
- **Stealth and Survival:** Tránh bị phát hiện, tìm nơi ẩn nấp và trốn thoát khỏi thực thể.
- **Horror and Storytelling:** Khám phá cốt truyện thông qua môi trường, âm thanh, ghi chú và những sự kiện đáng sợ.

---

## 2. Core Idea

### 2.1. High Concept

Người chơi phải giải những câu đố liên kết với bí mật của địa điểm để mở đường thoát thân.

Trong lúc đó, một thực thể bí ẩn liên tục tìm kiếm người chơi. Người chơi phải cân nhắc giữa việc tiếp tục khám phá và tìm nơi ẩn nấp trước khi bị phát hiện.

### 2.2. Core Gameplay Loop

```text
Explore the Environment
          |
          v
     Find Clues
          |
          v
    Solve Puzzles
          |
          v
 Unlock New Areas
          |
          v
The Entity Starts Searching
          |
          v
    Hide or Escape
          |
          v
  Discover the Story
          |
          v
   Find the Exit
```

### 2.3. Player Experience

Trò chơi hướng đến việc khiến người chơi thường xuyên tự hỏi:

- Manh mối này có ý nghĩa gì?
- Thực thể đang ở đâu?
- Mình có đủ thời gian giải câu đố không?
- Có nên tiếp tục khám phá hay tìm chỗ trốn?
- Chuyện gì thực sự đã xảy ra tại nơi này?

---

## 3. Story

### 3.1. Setting

Người chơi tỉnh dậy trong một công trình vắng vẻ, bị cô lập khỏi thế giới bên ngoài.

Điện hoạt động chập chờn. Nhiều cánh cửa bị khóa. Các căn phòng chứa những dấu vết cho thấy nơi này từng xảy ra một sự cố nghiêm trọng.

Người chơi không nhớ rõ mình đã đến đây bằng cách nào.

Lối ra duy nhất bị khóa bởi một hệ thống phức tạp. Muốn mở được nó, người chơi phải tìm hiểu các manh mối nằm rải rác khắp công trình.

Trong bóng tối có thứ gì đó đang di chuyển.

Ban đầu, người chơi chỉ nghe thấy tiếng bước chân, tiếng kim loại va chạm hoặc những âm thanh khó xác định. Càng tiến sâu, người chơi càng nhận ra rằng thực thể ấy đang tìm kiếm mình.

### 3.2. Storytelling

Cốt truyện được hé lộ dần thông qua:

- Ghi chú, nhật ký và thư từ.
- Băng ghi âm hoặc thiết bị lưu trữ dữ liệu.
- Những căn phòng bị bỏ hoang.
- Các dấu vết trên môi trường.
- Những sự kiện đặc biệt khi người chơi tiến đến khu vực quan trọng.
- Những thay đổi trong hành vi của thực thể theo tiến trình chơi.

### 3.3. Narrative Design

Không giải thích tất cả ngay từ đầu.

Mỗi manh mối nên cung cấp một phần thông tin, đồng thời tạo ra câu hỏi mới. Người chơi sẽ dần hiểu được nguyên nhân của sự cố, bản chất của thực thể và lý do mình bị mắc kẹt.

*Chi tiết cốt truyện, danh tính thực thể và kết thúc sẽ được xác định trong quá trình phát triển.*

---

## 4. Player Objectives

Mục tiêu chính là **tìm hiểu bí mật của địa điểm và trốn thoát an toàn**.

Người chơi cần:

1. Khám phá các khu vực có thể tiếp cận.
2. Tìm vật phẩm và manh mối quan trọng.
3. Giải các câu đố để mở khóa khu vực mới.
4. Khôi phục nguồn điện hoặc kích hoạt các cơ chế cần thiết.
5. Tránh né thực thể trong quá trình khám phá.
6. Tìm ra sự thật đằng sau những sự kiện đã xảy ra.
7. Mở lối thoát cuối cùng và hoàn thành trò chơi.

---

## 5. Gameplay Mechanics

### 5.1. Player Controls

Các điều khiển dự kiến:

| Input | Action |
|---|---|
| `W`, `A`, `S`, `D` | Di chuyển |
| `Mouse` | Quan sát |
| `Shift` | Chạy |
| `Ctrl` hoặc `C` | Cúi người |
| `E` | Tương tác, nhặt vật phẩm |
| `Tab` hoặc `I` | Mở túi đồ |
| `Esc` | Tạm dừng |

Các phím có thể thay đổi trong phần Settings.

### 5.2. Exploration

Người chơi có thể tương tác với:

- Cửa, công tắc và bảng điều khiển.
- Chìa khóa, cầu chì và vật phẩm nhiệm vụ.
- Ghi chú, nhật ký và thiết bị lưu trữ thông tin.
- Tủ, gầm bàn hoặc các vị trí có thể dùng để ẩn nấp.
- Các cơ chế câu đố được bố trí trong môi trường.

Một vật thể có thể tương tác nên có dấu hiệu trực quan hoặc lời nhắc phù hợp, nhưng không nên làm lộ toàn bộ lời giải.

### 5.3. Interaction System

Luồng tương tác cơ bản:

```text
Player Looks at Object
          |
          v
Check Interaction Range
          |
          v
Show Interaction Prompt
          |
          v
Player Presses Interact
          |
          v
Execute Interaction
          |
          v
Update Game State
```

### 5.4. Inventory and Items

Túi đồ được thiết kế gọn nhẹ để giữ trọng tâm vào kinh dị và giải đố.

Các vật phẩm dự kiến:

- **Keys:** Mở cửa hoặc khu vực bị khóa.
- **Fuses:** Khôi phục nguồn điện.
- **Tools:** Hỗ trợ tương tác với môi trường.
- **Documents:** Cung cấp manh mối và thông tin cốt truyện.
- **Puzzle Items:** Các vật phẩm cần sử dụng để giải câu đố.

Không nhất thiết phải có hệ thống chế tạo, chiến đấu hoặc sinh tồn phức tạp nếu chúng không phục vụ trực tiếp cho trải nghiệm chính.

---

## 6. Puzzle System

### 6.1. Puzzle Design Principles

Mỗi câu đố nên có:

- **Objective:** Người chơi cần mở khóa hoặc kích hoạt điều gì?
- **Clues:** Những thông tin nào giúp tìm ra lời giải?
- **Interaction:** Người chơi cần thực hiện thao tác gì?
- **Feedback:** Trò chơi phản hồi thế nào khi người chơi làm đúng hoặc sai?
- **Progression:** Lời giải giúp người chơi tiến xa hơn ra sao?

Câu đố nên dựa trên thông tin người chơi có thể quan sát hoặc tìm thấy trong thế giới, thay vì yêu cầu đoán ngẫu nhiên.

### 6.2. Puzzle Types

#### A. Code Puzzle

Người chơi tìm các con số trong ghi chú, hình vẽ hoặc đồ vật để mở khóa cửa và két.

#### B. Power Puzzle

Người chơi tìm cầu chì, bật công tắc hoặc khôi phục nguồn điện để kích hoạt một hệ thống.

#### C. Symbol Puzzle

Người chơi tìm quy luật từ những biểu tượng trong môi trường rồi nhập đúng thứ tự.

#### D. Item Puzzle

Người chơi tìm vật phẩm phù hợp và sử dụng chúng đúng vị trí để mở đường.

#### E. Environmental Puzzle

Người chơi quan sát ánh sáng, âm thanh, vị trí đồ vật hoặc cấu trúc căn phòng để vượt qua chướng ngại.

### 6.3. Puzzle Under Pressure

Một số câu đố có thể buộc người chơi thao tác trong lúc thực thể đang ở gần.

Ví dụ: người chơi phải tìm đúng công tắc trong phòng tối trong khi nghe thấy tiếng bước chân tiến lại gần.

Tuy nhiên, không phải câu đố nào cũng cần giới hạn thời gian. Người chơi vẫn cần có cơ hội quan sát và suy luận.

---

## 7. The Entity

### 7.1. Overview

Thực thể là nguồn nguy hiểm chính và là yếu tố tạo áp lực xuyên suốt trò chơi.

Nó không nhất thiết phải xuất hiện liên tục. Đôi khi, âm thanh, bóng dáng thoáng qua hoặc dấu vết của nó có thể đáng sợ hơn việc nhìn thấy trực tiếp.

### 7.2. AI States

```text
Idle
  |
  v
Patrol / Search
  |
  v
Detect Player
  |
  v
Investigate
  |
  v
Chase
  |
  v
Attack / Jumpscare
  |
  v
Search Again
```

Các trạng thái:

- **Idle:** Đứng yên hoặc chờ điều kiện kích hoạt.
- **Patrol:** Di chuyển giữa các khu vực.
- **Search:** Tìm kiếm người chơi trong khu vực nghi ngờ.
- **Detect Player:** Phát hiện người chơi.
- **Investigate:** Tiến đến vị trí có âm thanh hoặc dấu hiệu đáng ngờ.
- **Chase:** Truy đuổi người chơi.
- **Attack:** Bắt được người chơi và kích hoạt sự kiện thất bại.
- **Search Again:** Mất dấu người chơi và tiếp tục tìm kiếm.

### 7.3. Detection System

Thực thể có thể phát hiện người chơi thông qua:

- **Vision:** Người chơi nằm trong phạm vi quan sát và không bị vật cản che khuất.
- **Sound:** Chạy, va chạm hoặc tương tác gây tiếng động.
- **Distance:** Người chơi tiến quá gần.
- **Scripted Events:** Một số hành động hoặc tiến trình câu đố kích hoạt sự xuất hiện của thực thể.

Đây là các cơ chế dự kiến, chưa phải danh sách tính năng đã hoàn thành.

### 7.4. Difficulty Balance

- Cung cấp dấu hiệu cảnh báo trước khi nguy hiểm đến gần.
- Bố trí các lựa chọn di chuyển hoặc nơi ẩn nấp hợp lý.
- Không để thực thể biết chính xác vị trí người chơi trong mọi tình huống.
- Điều chỉnh tốc độ, tầm phát hiện và thời gian tìm kiếm theo độ khó.
- Hạn chế jumpscare xuất hiện quá thường xuyên.

---

## 8. Horror and Jumpscare System

### 8.1. Horror Design

Jumpscare là một phần của trải nghiệm kinh dị, không phải công cụ thay thế cho toàn bộ thiết kế.

Cảm giác sợ hãi được xây dựng từ:

- Sự chờ đợi.
- Âm thanh bất thường.
- Không gian thiếu ánh sáng.
- Những dấu hiệu cho thấy có thứ gì đó đang ở gần.
- Việc không biết thực thể đang ở đâu.
- Những sự kiện xảy ra ngoài dự đoán.

### 8.2. Scare Types

- **Audio Scare:** Tiếng động bất ngờ phát ra từ một vị trí cụ thể.
- **Visual Scare:** Một bóng hình xuất hiện thoáng qua trong tầm nhìn.
- **Environmental Scare:** Đèn tắt, cửa đóng hoặc đồ vật thay đổi trạng thái.
- **Chase Sequence:** Thực thể xuất hiện và bắt đầu truy đuổi.
- **Capture Jumpscare:** Sự kiện khi thực thể bắt được người chơi.

### 8.3. Jumpscare Flow

```text
Scare Condition Triggered
          |
          v
Check Player State
          |
          v
Play Animation / Audio / VFX
          |
          v
Control Player Input if Required
          |
          v
Death Screen / Checkpoint / Scripted Event
```

Cảnh jumpscare cần đồng bộ giữa hoạt ảnh, âm thanh, camera và trạng thái gameplay.

Sau cảnh này, trò chơi phải chuyển sang một trạng thái hợp lệ, chẳng hạn tải lại checkpoint hoặc kết thúc màn chơi.

---

## 9. Level Design

### 9.1. Level Structure

Địa điểm chính có thể là một công trình bị bỏ hoang, được chia thành các khu vực có liên kết với nhau.

```text
Starting Room
      |
      v
Main Corridor
  |       |
  v       v
Office   Storage Room
  |       |
  v       v
Key Item  Power Puzzle
      \   /
       v v
  Restricted Area
         |
         v
    Final Puzzle
         |
         v
       Exit
```

Sơ đồ chỉ mang tính minh họa. Bố cục thực tế sẽ phụ thuộc vào cốt truyện và quy mô dự án.

### 9.2. Level Design Principles

- Sử dụng ánh sáng và vật thể để hướng người chơi đến khu vực quan trọng.
- Tạo các đường vòng để việc quay lại khu vực cũ không nhàm chán.
- Đặt manh mối ở vị trí hợp lý và có liên quan đến câu đố.
- Tạo khu vực an toàn tương đối và khu vực nguy hiểm để thay đổi nhịp độ.
- Tránh để người chơi bị mắc kẹt chỉ vì không nhận ra một vật phẩm quá khó quan sát.

---

## 10. UI/UX

### 10.1. Main Menu

```text
Main Menu
├── New Game
├── Continue
├── Settings
└── Quit
```

`Continue` chỉ khả dụng khi có dữ liệu lưu phù hợp.

### 10.2. HUD

HUD nên tối giản để không phá vỡ không khí kinh dị.

Các thành phần dự kiến:

- Crosshair hoặc dấu hiệu tương tác.
- Interaction Prompt.
- Thông báo vật phẩm vừa nhặt.
- Mục tiêu hiện tại khi cần thiết.
- Hiệu ứng trạng thái nguy hiểm nếu phù hợp với gameplay.

Không nên luôn hiển thị vị trí của thực thể, vì việc không biết nó đang ở đâu là một phần quan trọng của trải nghiệm.

### 10.3. Pause Menu

```text
Pause Menu
├── Resume
├── Settings
├── Restart Checkpoint
└── Main Menu
```

Các lựa chọn thực tế sẽ phụ thuộc vào hệ thống lưu game được triển khai.

### 10.4. Settings

Các tùy chọn dự kiến:

- Master Volume.
- Music Volume.
- SFX Volume.
- Mouse Sensitivity.
- Graphics Quality.
- Brightness.
- Subtitles.
- Controls.

---

## 11. Audio and Visual Design

### 11.1. Art Direction

Phong cách hình ảnh sẽ được lựa chọn sao cho phù hợp với khả năng sản xuất của nhóm.

Ưu tiên bố cục dễ đọc, ánh sáng có chủ đích và các chi tiết môi trường hỗ trợ kể chuyện.

### 11.2. Lighting

- Ánh sáng yếu để tạo cảm giác bất an.
- Đèn nhấp nháy hoặc mất điện trong các sự kiện có chủ đích.
- Tương phản giữa vùng sáng và vùng tối để định hướng thị giác.
- Tránh làm khu vực tối đến mức người chơi không thể quan sát manh mối cần thiết.

### 11.3. Sound Design

Âm thanh giúp người chơi suy đoán vị trí và trạng thái của thực thể.

Các lớp âm thanh dự kiến:

- **Ambience:** Tiếng gió, tiếng điện và âm thanh môi trường.
- **Footsteps:** Tiếng bước chân của người chơi và thực thể.
- **Interaction SFX:** Tiếng mở cửa, kéo vật thể và bật công tắc.
- **Entity Audio:** Âm thanh đặc trưng khi thực thể ở gần hoặc phát hiện người chơi.
- **Music:** Nhạc nền được sử dụng có chọn lọc để tạo căng thẳng.
- **Scare Audio:** Âm thanh dành cho các sự kiện kinh dị.

---

## 12. Game Progression

### Stage 1 — WAKE UP

Người chơi tỉnh dậy tại khu vực bắt đầu, tìm hiểu cách di chuyển và khám phá những vật thể đầu tiên.

### Stage 2 — EXPLORE

Người chơi tìm thấy các căn phòng, ghi chú và manh mối cho thấy đã có chuyện bất thường xảy ra.

### Stage 3 — FIRST ENCOUNTER

Người chơi lần đầu nhận ra sự tồn tại của thực thể. Mục tiêu chuyển từ khám phá đơn thuần sang khám phá có kiểm soát và tìm cách tránh bị phát hiện.

### Stage 4 — SOLVE

Người chơi giải các câu đố chính, thu thập vật phẩm cần thiết và mở những khu vực bị khóa.

### Stage 5 — REVEAL

Các manh mối dần kết nối với nhau, hé lộ sự thật quan trọng về địa điểm và thực thể.

### Stage 6 — ESCAPE

Người chơi giải câu đố cuối cùng, mở lối thoát và tìm cách rời khỏi khu vực trước khi bị bắt.

```text
WAKE UP
   |
   v
EXPLORE
   |
   v
FIND CLUES
   |
   v
ENCOUNTER THE ENTITY
   |
   v
SOLVE PUZZLES
   |
   v
DISCOVER THE TRUTH
   |
   v
UNLOCK THE EXIT
   |
   v
ESCAPE
```

---

## 13. Win and Lose Conditions

### 13.1. Win Condition

Người chơi chiến thắng khi hoàn thành các mục tiêu bắt buộc, giải được câu đố cuối cùng và thoát khỏi khu vực theo điều kiện kết thúc đã thiết kế.

### 13.2. Lose Condition

Người chơi có thể thất bại khi:

- Bị thực thể bắt được.
- Thất bại trong một sự kiện đặc biệt có điều kiện thua rõ ràng.
- Không hoàn thành thử thách trong thời gian giới hạn, nếu màn chơi có cơ chế này.

### 13.3. Checkpoint System

Có thể sử dụng checkpoint tại các mốc tiến trình quan trọng để giảm sự khó chịu khi chơi lại.

Khi thất bại, trò chơi cần xác định rõ những gì được giữ lại và những gì cần thực hiện lại.

---

## 14. Technical Design

### 14.1. Technologies

- **Unity:** Game engine.
- **C#:** Gameplay scripting.
- **NavMesh hoặc giải pháp điều hướng phù hợp:** Hỗ trợ di chuyển AI trong môi trường.
- **Unity Audio:** Phát và quản lý âm thanh.
- **Unity UI:** Xây dựng menu, HUD và giao diện câu đố.
- **Unity Animator:** Quản lý hoạt ảnh nhân vật và thực thể.
- **Unity Scene Management:** Chuyển scene hoặc tải lại checkpoint.

Package cụ thể sẽ được quyết định theo phiên bản Unity và nhu cầu thực tế của dự án.

### 14.2. Core Systems

| System | Responsibility |
|---|---|
| Player Controller | Di chuyển, quan sát và tương tác |
| Interaction System | Xử lý tương tác với vật thể |
| Inventory / Item System | Lưu trữ và sử dụng vật phẩm |
| Puzzle System | Theo dõi trạng thái và kiểm tra lời giải |
| Enemy AI | Tuần tra, tìm kiếm, phát hiện và truy đuổi |
| Audio System | Quản lý âm thanh môi trường và sự kiện |
| Scare / Event System | Kích hoạt các sự kiện kinh dị |
| Game State Manager | Quản lý trạng thái chơi, thắng và thua |
| Save / Checkpoint System | Lưu tiến trình và khôi phục khi cần |
| UI System | Menu, HUD, thông báo và màn hình kết thúc |

---

## 15. Development Scope

Để có thể hoàn thành một phiên bản chơi được, nên ưu tiên một màn chơi nhỏ nhưng hoàn chỉnh trước khi mở rộng.

### 15.1. MVP — Minimum Viable Product

#### Player

- [ ] First-person controller.
- [ ] Camera movement.
- [ ] Interaction system.
- [ ] Sprint hoặc crouch nếu cần cho gameplay.

#### Level

- [ ] Xây dựng một khu vực chơi hoàn chỉnh.
- [ ] Bố trí cửa khóa và lối thoát.
- [ ] Bố trí vật phẩm và manh mối.
- [ ] Thiết lập ánh sáng và âm thanh môi trường.

#### Puzzle

- [ ] Có ít nhất một câu đố hoàn chỉnh.
- [ ] Có manh mối hướng dẫn người chơi.
- [ ] Có phản hồi khi thao tác đúng hoặc sai.
- [ ] Câu đố mở khóa một phần tiến trình.

#### Entity

- [ ] Mô hình hoặc hình dáng thực thể.
- [ ] Di chuyển và tuần tra.
- [ ] Phát hiện người chơi theo điều kiện cơ bản.
- [ ] Truy đuổi người chơi.
- [ ] Xử lý khi bắt được người chơi.

#### Horror

- [ ] Có âm thanh cảnh báo thực thể.
- [ ] Có ít nhất một sự kiện kinh dị được dàn dựng.
- [ ] Có cảnh bắt được người chơi hoặc jumpscare.
- [ ] Có màn hình thất bại và cách chơi lại.

#### Game Flow

- [ ] Main Menu.
- [ ] Bắt đầu màn chơi.
- [ ] Điều kiện thắng.
- [ ] Điều kiện thua.
- [ ] Restart hoặc checkpoint cơ bản.

### 15.2. Future Features

- [ ] Nhiều loại câu đố.
- [ ] Nhiều hành vi AI cho thực thể.
- [ ] Nhiều khu vực hoặc màn chơi.
- [ ] Nhiều kết thúc dựa trên manh mối.
- [ ] Hệ thống lưu game hoàn chỉnh.
- [ ] Tùy chọn độ khó.
- [ ] Phụ đề và tùy chỉnh accessibility.
- [ ] Các sự kiện kinh dị thay đổi theo tiến trình.

---

## 16. Development Roadmap

### Phase 1 — Prototype

- [ ] Tạo project Unity và cấu trúc scene.
- [ ] Hoàn thiện điều khiển người chơi.
- [ ] Tạo hệ thống tương tác cơ bản.
- [ ] Tạo một câu đố thử nghiệm.
- [ ] Tạo AI thực thể ở mức đơn giản.

### Phase 2 — Vertical Slice

- [ ] Hoàn thành một khu vực chơi ngắn.
- [ ] Kết nối câu đố với tiến trình màn chơi.
- [ ] Hoàn thiện một chuỗi truy đuổi.
- [ ] Thêm âm thanh, ánh sáng và jumpscare.
- [ ] Tạo được một lượt chơi từ đầu đến cuối.

### Phase 3 — Content Production

- [ ] Hoàn thiện các khu vực còn lại.
- [ ] Bổ sung manh mối và nội dung cốt truyện.
- [ ] Thêm câu đố và sự kiện mới.
- [ ] Hoàn thiện hoạt ảnh và hiệu ứng.
- [ ] Tối ưu hiệu năng.

### Phase 4 — Testing and Polish

- [ ] Kiểm tra lỗi gameplay.
- [ ] Kiểm tra các trường hợp AI bị mắc kẹt.
- [ ] Kiểm tra câu đố có thể hoàn thành hay không.
- [ ] Điều chỉnh độ khó và nhịp độ kinh dị.
- [ ] Kiểm tra âm thanh, ánh sáng và hiệu năng.
- [ ] Hoàn thiện màn hình thắng và thua.

---

## 17. Unity Project Structure

Cấu trúc thư mục tham khảo:

```text
Assets/
├── Animations/
├── Audio/
│   ├── Ambience/
│   ├── Music/
│   ├── SFX/
│   └── Entity/
├── Materials/
├── Models/
│   ├── Environment/
│   ├── Props/
│   └── Characters/
├── Prefabs/
│   ├── Player/
│   ├── Entity/
│   ├── Interactables/
│   └── Puzzles/
├── Scenes/
├── Scripts/
│   ├── Player/
│   ├── Interaction/
│   ├── Inventory/
│   ├── Puzzles/
│   ├── AI/
│   ├── Audio/
│   ├── UI/
│   └── GameManagement/
├── ScriptableObjects/
├── UI/
└── VFX/
```

Đây là cấu trúc gợi ý; có thể điều chỉnh theo quy mô dự án và cách tổ chức của nhóm.

---

## 18. Core Design Principles

### 1. Fear Over Combat

Trọng tâm là cảm giác dễ bị tổn thương, không phải chiến đấu trực diện với thực thể.

### 2. Clues Must Matter

Manh mối cần có ý nghĩa và giúp người chơi suy luận, không chỉ được đặt để trang trí.

### 3. The Entity Must Feel Dangerous

Thực thể cần có dấu hiệu nhận biết, hành vi nhất quán và tạo áp lực thực sự, nhưng vẫn phải công bằng với người chơi.

### 4. Jumpscares Need Build-up

Jumpscare nên có sự chuẩn bị về không khí, âm thanh hoặc tình huống để tránh trở nên nhàm chán.

### 5. Every Puzzle Moves the Story Forward

Mỗi câu đố nên mở ra khu vực mới, cung cấp thông tin hoặc thay đổi trạng thái gameplay.

### 6. Finish a Small Game First

Ưu tiên một trải nghiệm ngắn, hoàn chỉnh và có thể chơi từ đầu đến cuối trước khi mở rộng quy mô.

---

## Project Status

| Feature | Status |
|---|---|
| Core Concept | Planned |
| Story and Lore | In Development |
| Player Controller | Planned |
| Puzzle System | Planned |
| Entity AI | Planned |
| Horror Events | Planned |
| Level Design | Planned |
| UI / UX | Planned |
| Ending | Planned |

---

## Core Experience

```text
EXPLORE
   |
   v
FIND CLUES
   |
   v
SOLVE THE PUZZLE
   |
   v
MAKE NOISE / TRIGGER AN EVENT
   |
   v
THE ENTITY STARTS SEARCHING
   |
   v
HIDE OR ESCAPE
   |
   v
UNCOVER THE TRUTH
   |
   v
FIND A WAY OUT
```

> **You are not trying to defeat the thing hunting you. You are trying to understand the place, survive its presence, and escape.**
